using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightPlanApi.Controllers
{
    [Route("api/v1/flightplan")]
    [ApiController]
    public class FlightPlanController : ControllerBase
    {
        private IDatabaseAdapter _database;

        public FlightPlanController(IDatabaseAdapter database){
            _database = database;
        }

        [HttpGet]
        public async Task<IActionResult> FlightPlanList(){

        }

        [HttpGet]
        [Route("{flightPlanId}")]
        public async Task<IActionResult> GetFlightPlanById(string flightPlanId){

        }

        [HttpPost]
        [Route("file")]
        public async Task<IActionResult> FileFlightPlan(FlightPlan flightplan){

        }

        [HttpPut]
        public async Task<IActionResult> UpdateFileFlightPlan(FlightPlanApi flightplan){

        }

        [HttpDelete]
        [Route("{flightPlanId}")]
        public async Tasl<IActionResult> DeleteFlightPlan( string flightPlanId){

        }

        [HttpGet]
        [Route("airport/departure/{flightPlanId}")]
        public async Tasl<IActionResult> GetFlightPlanDepartureAirport( string flightPlanId){
            
        }

        [HttpGet]
        [Route("route/{flightPlanId}")]
        public async Tasl<IActionResult> GetFlightPlanRoute( string flightPlanId){
            
        }

        [HttpGet]
        [Route("time/enroute/{flightPlanId}")]
        public async Tasl<IActionResult> GetFlightPlanTimeEnroute( string flightPlanId){
            
        }
        
    }
}
