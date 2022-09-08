using Amazon.DynamoDBv2.DataModel;
using AWSServerless2022.Model;
using Microsoft.AspNetCore.Mvc;

namespace AWSServerless2022.Controllers;

[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    IDynamoDBContext _dynamoDbContext;
    public ValuesController(IDynamoDBContext dynamoDbContext)
    {
        _dynamoDbContext = dynamoDbContext;
    }

    // GET api/values
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            var employees = await _dynamoDbContext.ScanAsync<Employees>(default).GetRemainingAsync();
            return Ok(employees);
        }
        catch (Exception ex)
        {

            throw;
        }
      
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody]string value)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}