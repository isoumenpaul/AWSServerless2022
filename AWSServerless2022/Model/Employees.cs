using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSServerless2022.Model
{
    [DynamoDBTable("Employee")]
    public class Employees
    {
        
        [DynamoDBHashKey("Employee_Id")]
        public int? Id { get; set; }

        [DynamoDBProperty("Name")]
        public string? Name { get; set; }

        [DynamoDBProperty("ContactNo")]
        public string? ContactNo { get; set; }

        [DynamoDBProperty("Country")]
        public string? Country { get; set; }

        [DynamoDBProperty("Resident")]
        public string? Resident { get; set; }

        [DynamoDBProperty("Weight")]
        public string? Weight { get; set; }
    }
}
