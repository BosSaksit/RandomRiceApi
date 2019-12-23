using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RandomRiceApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace RandomRiceApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class MenuRiceController : ControllerBase
    {
        public static List<MenuRice> DataMenuRice = new List<MenuRice>
        {
            new MenuRice { IdRice = "134560" , NameRice = "กะเพราหมูสับไข่ดาว"},
            new MenuRice { IdRice = "134561" , NameRice = "กะเพราหมูกรอบไข่ดาว"},
            new MenuRice { IdRice = "134562" , NameRice = "กะเพราปลากทอดไข่ดาว"},
            new MenuRice { IdRice = "134563" , NameRice = "กะเพราหมูชิ้นไข่ดาว"},
            new MenuRice { IdRice = "134564" , NameRice = "หมูทอดกระเทียมไข่ดาว"},
            new MenuRice { IdRice = "134565" , NameRice = "พริกเผาหมูกรอบไข่ดาว"},
            new MenuRice { IdRice = "134566" , NameRice = "พริกแกงหมูกรอบไข่ดาว"},
            new MenuRice { IdRice = "134567" , NameRice = "ไข่ยัดไส้"},
            new MenuRice { IdRice = "134568" , NameRice = "สุกี้แห้งทะเล"},
            // Rice { PollId = "102102" ,HomeTeamName = "Korea" ,AwayTeamName = "thailand" ,DateBall = "2019-12-14T16:05:28.607+07:00" , TimeBall = "2019-12-14T16:05:28.607+07:00" , TimeEndPoll = "2019-12-14T16:05:28.607+07:00" , ScoreBall = "1-1" ,VoteHomeTeam = {} , VoteAwayTeam = {} , PollStatus = "เปิด" , LuckyName = "vvv" , LuckyTel = "031001201"}
        };

        [HttpGet]
        public ActionResult<IEnumerable<MenuRice>> GetAllMenuRice()
        {
            return DataMenuRice.ToArray();
        }

        [HttpPost]
        public MenuRice AddPoll([FromBody] MenuRice data)
        {
            var id = Guid.NewGuid().ToString();
            var item = new MenuRice
            {
              IdRice = id.ToString(),
              NameRice = data.NameRice
            };
            DataMenuRice.Add(item);
            return item;
        }
    }
}