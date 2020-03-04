using Newtonsoft.Json;
using StarWarAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace StarWarAPI.Controllers
{
    public class StarWarController : ApiController
    {
        DataAccess db;
        public StarWarController()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConStr"].ToString();
            db = new DataAccess(constr);
        }

        [ResponseType(typeof(string))]
        [Route("api/OpeningCrawl")]
        public async Task<IHttpActionResult> GetOpeningCrawl()
        {
            string query = "select * from films where LEN(opening_crawl)=(Select MAX(LEN(opening_crawl)) From Films);";
            DataTable dt = await db.ExecuteSqlQuery(query);
            string JSONString = JsonConvert.SerializeObject(dt);
            return Ok(JSONString);
        }

        [ResponseType(typeof(string))]
        [Route("api/CharacterAppearance")]
        public async Task<IHttpActionResult> GetCharacterAppearance()
        {
            string query = "Select * from people where id = (select top 1 people_id from films_characters group by people_id order by Count(film_id) desc);";
            DataTable dt = await db.ExecuteSqlQuery(query);
            string JSONString = JsonConvert.SerializeObject(dt);
            return Ok(JSONString);
        }

        [ResponseType(typeof(string))]
        [Route("api/GetSpeciesAppeared")]
        public async Task<IHttpActionResult> GetSpeciesAppeared()
        {
            string query = "select top 5 s.name,count(*) AS [count] from people p inner join films_characters f on p.id=f.people_id " +
                           "inner join films f1 on f1.id=f.film_id inner join films_species f2 on f1.id=f2.film_id " +
                           "inner join species s on s.id=f2.species_id group by s.name order by count(*) desc ";
            DataTable dt = await db.ExecuteSqlQuery(query);
            string JSONString = JsonConvert.SerializeObject(dt);
            return Ok(JSONString);
        }

        [ResponseType(typeof(string))]
        [Route("api/GetVehiclePilots")]
        public async Task<IHttpActionResult> GetVehiclePilots()
        {
            //Query for Planets and its counts
            string query = "select top 10 p1.name, count(*) AS [count],STUFF((SELECT DISTINCT top 2 ', ' + p3.name + '-' + s3.name " +
                           "from people p3 inner join films_characters f3 on p3.id=f3.people_id " +
                           "inner join films f13 on f13.id=f3.film_id inner join films_species f23 on f13.id=f23.film_id " +
                           "inner join species s3 on s3.id=f23.species_id inner join films_planets fp3 on fp3.film_id=f13.id " +
                           "inner join planets p13 on p13.id=fp3.planet_id inner join vehicles_pilots vp3 on vp3.people_id=p3.id " +
                           "inner join vehicles v3 on v3.id=vp3.vehicle_id WHERE p13.name=p1.name FOR XML PATH('')), 1, 1, '') AS pilots " +
                           "from people p inner join films_characters f on p.id=f.people_id " +
                           "inner join films f1 on f1.id=f.film_id inner join films_species f2 on f1.id=f2.film_id " +
                           "inner join species s on s.id=f2.species_id inner join films_planets fp on fp.film_id=f1.id " +
                           "inner join planets p1 on p1.id=fp.planet_id inner join vehicles_pilots vp on vp.people_id=p.id " +
                           "inner join vehicles v on v.id=vp.vehicle_id group by p1.name order by p1.name ";
            DataTable dt_planets_data = await db.ExecuteSqlQuery(query);
            string JSONString = JsonConvert.SerializeObject(dt_planets_data);
            return Ok(JSONString);
        }

    }
}
