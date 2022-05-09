using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CalculationAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalcController : ApiController
    {
        /// <summary>This method handles the post request to the API controller,
        /// Only text file is supported at this moment.
        /// Returns response as HttpResponseMessage, after checking the provided file.
        /// </summary>
        [HttpGet]
        [Route("api/calc")]
        public IHttpActionResult Get( string action, string numbers )
        {
            try
            {
                // check if the request contains proper parameter
                if ( (string.IsNullOrEmpty(action)) || (string.IsNullOrEmpty(numbers)) )
                {
                    return BadRequest("The parameter is empty, please send some data to work on!");
                }
                if ( action == "sumandcheck" )
                {
                    // split the given numbers to string array and convert the array to integer array
                    string[] numStrings = numbers.Split(',');
                    int[] nums = Array.ConvertAll(numStrings, s => int.Parse(s));

                    // calculate the sum
                    int sum = 0;
                    foreach ( int i in nums )
                    {
                        sum += i;
                    }
                    // check if the number is prime and return the response
                    bool isSumPrime = CheckPrime(sum) ;
                    return Ok(new { result = sum, isPrime = isSumPrime });
                }
                else if( action == "checkprime" )
                {
                    int num = Int32.Parse(numbers);
                    return Ok(new { isPrime = CheckPrime(num) });
                }
                else
                {
                    return BadRequest("The parameter is incorrect!!!");
                }
                //retunrn the response with formated string
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        /// <summary>This method checks if a given number is Prime or not,
        /// Returns bollean, True or False.
        /// </summary>
        /// <param name="number">number to check as parameter</param>
        private bool CheckPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            for(int i=2; i<number; i++)
            {
                if( number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
