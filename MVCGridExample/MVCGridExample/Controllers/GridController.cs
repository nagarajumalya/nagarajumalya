using MVCGridExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using Newtonsoft.Json;

namespace MVCGridExample.Controllers
{
    public class GridController : Controller
    {

        //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Metadata
        {
            public double confidenceScore { get; set; }
        }

        public class Result
        {
            public int id { get; set; }
            public double score { get; set; }
            public string path { get; set; }
        }

        public class Root
        {
            public string status { get; set; }
            public int count { get; set; }
            public Metadata metadata { get; set; }
            public List<Result> results { get; set; }
        }
        // GET: Grid
        public ActionResult Index()
        { 
            
           // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
            ViewData["selectedResumeViewer"] = "active";
          


            ////Using DataTable, here you have to import System.Data  

            //DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(jsonString);


            GridModelList glm = new GridModelList();
            List<GridModel> gl = new List<GridModel>();
            GridModel gm = new GridModel();
            gm.Id = 1;
            gm.Name = "Test1";
            gm.Desc = "Test 1 Description";
            gm.Date = "29-03-2019";
            gl.Add(gm);

            GridModel gm1 = new GridModel();
            gm1.Id = 2;
            gm1.Name = "Test2";
            gm1.Desc = "Test 2 Description";
            gm1.Date = "30-03-2019";
            gl.Add(gm1);

            GridModel gm2 = new GridModel();
            gm2.Id = 3;
            gm2.Name = "Test3";
            gm2.Desc = "Test 3 Description";
            gm2.Date = "01-04-2019";
            gl.Add(gm2);

            glm.GridData = gl;

            return View("~/Views/Grid/GridView.cshtml", glm);
        }
    }
}