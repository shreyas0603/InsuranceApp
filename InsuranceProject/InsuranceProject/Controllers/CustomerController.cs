﻿using InsuranceDay1.Models;
using InsuranceProject.DTO;
using InsuranceProject.Exceptions;
using InsuranceProject.Service;
using InsuranceProject.Services;
using InsuranceProject.Token_Creation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace InsuranceProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customerService;
        private IConfiguration _configuration;
        public CustomerController(ICustomerService customerService, IConfiguration configuration)
        {
            _customerService = customerService;
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var customerDTO = new List<CustomerDto>();
            var customers = _customerService.GetAll();
            if (customers.Count > 0)
            {
                foreach (var customer in customers)
                {
                    customerDTO.Add(ConvertToDTO(customer));
                }
                return Ok(customerDTO);
            }
            throw new EntityNotFoundError("Customer not found");
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var customer = _customerService.Get(id);
            if (customer == null)
            {
                throw new EntityNotFoundError("Customer not found");
            }
            return Ok(ConvertToDTO(customer));
        }
        [HttpPost]
        public IActionResult Add(CustomerDto customerDto)
        {
            var customer = ConvertToModel(customerDto);
            customer.Password = BCrypt.Net.BCrypt.HashPassword(customerDto.Password);
            var customerId = _customerService.Add(customer);
            if (customerId == null)
                throw new EntityInsertError("Some errors Occurred");
            return Ok(customerId);
        }
        [HttpPut]
        public IActionResult Update(CustomerDto customerDto)
        {
            var customerDTOToUpdate = _customerService.Check(customerDto.Id);
            if (customerDTOToUpdate != null)
            {
                var updatedCustomer = ConvertToModel(customerDto);
                var modifiedCustomer = _customerService.Update(updatedCustomer);
                return Ok(ConvertToDTO(modifiedCustomer));
            }
            throw new EntityNotFoundError("No Customer found to update");
        }
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var customer = _customerService.Get(id);
            if (customer != null)
            {
                _customerService.Delete(customer);
                return Ok(id);
            }
            throw new EntityNotFoundError("No Customer found to delete");
        }
        [HttpPost("Login")]
        public IActionResult Login(CustomerDto customerDto)
        {
            var customer = _customerService.FindCustomer(customerDto.UserName);
            //admin.RoleId = 1;
            var role = _customerService.GetRoleName(customer);
            if (customer != null)
            {
                if (BCrypt.Net.BCrypt.Verify(customerDto.Password, customer.Password))
                {
                    //return Ok("Login Successful");
                    string jwt = CreateToken<Customer>.CreateTokens(customer.UserName, role, _configuration);
                    return Ok(jwt);
                }
            }
            throw new EntityInsertError("UserName/Password dosesnt exist");
        }
        private Customer ConvertToModel(CustomerDto customerDto)
        {
            return new Customer()
            {
                Id = customerDto.Id,
                FirstName = customerDto.FirstName,
                LastName = customerDto.LastName,
                DateOfBirth = customerDto.DateOfBirth,
                UserName = customerDto.UserName,
                Password = customerDto.Password,
                MobileNumber = customerDto.MobileNumber,
                Email = customerDto.Email,
                NomineeName = customerDto.NomineeName,
                NomineeRelation = customerDto.NomineeRelation,
                LocationId = customerDto.LocationId,
                AgentId = customerDto.AgentId,
                RoleId = 3,

                IsActive = true

            };
        }
        private CustomerDto ConvertToDTO(Customer customer)
        {
            return new CustomerDto()
            {
               Id= customer.Id,
               FirstName = customer.FirstName,
               LastName = customer.LastName,
               DateOfBirth = customer.DateOfBirth,
               UserName = customer.UserName,
               Password = customer.Password,
               MobileNumber = customer.MobileNumber,
               Email = customer.Email,
               NomineeName= customer.NomineeName,
               NomineeRelation= customer.NomineeRelation,
               LocationId = customer.LocationId,
               AgentId = customer.AgentId,
               //RoleId = customer.RoleId,

            };
        }
    }
}
