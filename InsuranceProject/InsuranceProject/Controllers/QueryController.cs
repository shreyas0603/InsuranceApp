﻿using InsuranceDay1.Models;
using InsuranceProject.DTO;
using InsuranceProject.Service;
using InsuranceProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueryController : ControllerBase
    {
        private IQueryService _queryService;
        public QueryController(IQueryService queryService)
        {
            _queryService = queryService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var queryDTO = new List<QueryDto>();
            var queries = _queryService.GetAll();
            if (queries.Count > 0)
            {
                foreach (var query in queries)
                {
                    queryDTO.Add(ConvertToDTO(query));
                }
                return Ok(queryDTO);
            }
            return BadRequest("Contacts not found");
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var query = _queryService.Get(id);
            if (query == null)
            {
                return BadRequest("Contacts not found");
            }
            return Ok(ConvertToDTO(query));
        }
        [HttpPost]
        public IActionResult Add(QueryDto queryDto)
        {
            var query = ConvertToModel(queryDto);
            var QueryId = _queryService.Add(query);
            if (QueryId == null)
                return BadRequest("Some errors Occurred");
            return Ok(QueryId);
        }
        [HttpPut]
        public IActionResult Update(QueryDto queryDto)
        {
            var queryDTOToUpdate = _queryService.Check(queryDto.Id);
            if (queryDTOToUpdate != null)
            {
                var updatedQuery = ConvertToModel(queryDto);
                var modifiedQuery = _queryService.Update(updatedQuery);
                return Ok(ConvertToDTO(modifiedQuery));
            }
            return BadRequest("No contact found to update");
        }
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var query = _queryService.Get(id);
            if (query != null)
            {
                _queryService.Delete(query);
                return Ok(id);
            }
            return BadRequest("No contact found to delete");
        }
        private Query ConvertToModel(QueryDto queryDto)
        {
            return new Query()
            {
                Id = queryDto.Id,
                QueryTitle = queryDto.QueryTitle,
                QueryDate = queryDto.QueryDate,
                QueryMessage = queryDto.QueryMessage,
                Reply=queryDto.Reply,
                CustomerId = queryDto.CustomerId,
                IsActive=true
            };
        }
        private QueryDto ConvertToDTO(Query query)
        {
            return new QueryDto()
            {
                Id = query.Id,
                QueryTitle = query.QueryTitle,
                QueryDate = query.QueryDate,
                QueryMessage = query.QueryMessage,
                Reply = query.Reply,
                CustomerId = query.CustomerId,  
         
            };
        }
    }
}
