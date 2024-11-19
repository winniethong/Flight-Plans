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

        public async Task<IActionResult> FlightPlanList(){

        }

        public async Task<IActionResult> GetFlightPlanById(string flightPlanId){

        }

        public async Task<IActionResult> FileFlightPlan(FlightPlan flightplan){

        }

        public async Task<IActionResult> UpdateFileFlightPlan(FlightPlanApi flightplan){

        }

        public async Tasl<IActionResult> DeleteFlightPlan( string flightPlanId){

        }

        public async Tasl<IActionResult> GetFlightPlanDepartureAirport( string flightPlanId){
            
        }

        public async Tasl<IActionResult> GetFlightPlanRoute( string flightPlanId){
            
        }

        public async Tasl<IActionResult> GetFlightPlanTimeEnroute( string flightPlanId){
            
        }
    }
}
