using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fernando
{
    public class BaseDatos
    {
        public List<Materia> Materias
        {
            get { return nuevo; }
        }

        public List<Profesor> Teachers
        {
            get { return nuevingo; }
        }

        List<Materia> nuevo = new List<Materia>();
        List<Profesor> nuevingo = new List<Profesor>();

        public BaseDatos()
        {
            nuevo.Add(new Materia { Id = 1, TeacherId = 6, Nombre = "Medical-Surgical" });
            nuevo.Add(new Materia { Id = 2, TeacherId = 20, Nombre = "Consumer Behaviour" });
            nuevo.Add(new Materia { Id = 3, TeacherId = 24, Nombre = "HSM" });
            nuevo.Add(new Materia { Id = 4, TeacherId = 24, Nombre = "Bathrooms" });
            nuevo.Add(new Materia { Id = 5, TeacherId = 27, Nombre = "MRO Management" });
            nuevo.Add(new Materia { Id = 6, TeacherId = 9, Nombre = "DLC" });
            nuevo.Add(new Materia { Id = 7, TeacherId = 16, Nombre = "Commercial Awareness" });
            nuevo.Add(new Materia { Id = 8, TeacherId = 1, Nombre = "KDB+" });
            nuevo.Add(new Materia { Id = 9, TeacherId = 29, Nombre = "Townhomes" });
            nuevo.Add(new Materia { Id = 10, TeacherId = 21, Nombre = "WLM" });
            nuevo.Add(new Materia { Id = 11, TeacherId = 24, Nombre = "AHU" });
            nuevo.Add(new Materia { Id = 12, TeacherId = 21, Nombre = "Equipment Repair" });
            nuevo.Add(new Materia { Id = 13, TeacherId = 15, Nombre = "iPod" });
            nuevo.Add(new Materia { Id = 14, TeacherId = 5, Nombre = "HAZOP Study" });
            nuevo.Add(new Materia { Id = 15, TeacherId = 18, Nombre = "HR Consulting" });
            nuevo.Add(new Materia { Id = 16, TeacherId = 11, Nombre = "Errors &amp; Omissions" });
            nuevo.Add(new Materia { Id = 17, TeacherId = 29, Nombre = "PMBOK" });
            nuevo.Add(new Materia { Id = 18, TeacherId = 17, Nombre = "Xoops" });
            nuevo.Add(new Materia { Id = 19, TeacherId = 29, Nombre = "sFlow" });
            nuevo.Add(new Materia { Id = 20, TeacherId = 11, Nombre = "PPBES" });
            nuevo.Add(new Materia { Id = 21, TeacherId = 14, Nombre = "RPR" });
            nuevo.Add(new Materia { Id = 22, TeacherId = 16, Nombre = "Group Therapy" });
            nuevo.Add(new Materia { Id = 23, TeacherId = 4, Nombre = "BGAN" });
            nuevo.Add(new Materia { Id = 24, TeacherId = 5, Nombre = "Legal Advice" });
            nuevo.Add(new Materia { Id = 25, TeacherId = 15, Nombre = "DWR" });
            nuevo.Add(new Materia { Id = 26, TeacherId = 30, Nombre = "Talent Acquisition" });
            nuevo.Add(new Materia { Id = 27, TeacherId = 20, Nombre = "HTFS" });
            nuevo.Add(new Materia { Id = 28, TeacherId = 16, Nombre = "Juniper Technologies" });
            nuevo.Add(new Materia { Id = 29, TeacherId = 9, Nombre = "DHS" });
            nuevo.Add(new Materia { Id = 30, TeacherId = 29, Nombre = "GL" });
            nuevo.Add(new Materia { Id = 31, TeacherId = 1, Nombre = "Executive Protection" });
            nuevo.Add(new Materia { Id = 32, TeacherId = 25, Nombre = "Vital Signs" });
            nuevo.Add(new Materia { Id = 33, TeacherId = 18, Nombre = "Fixed Income" });
            nuevo.Add(new Materia { Id = 34, TeacherId = 18, Nombre = "Eclipse" });
            nuevo.Add(new Materia { Id = 35, TeacherId = 16, Nombre = "Sleep Disorders" });
            nuevo.Add(new Materia { Id = 36, TeacherId = 18, Nombre = "SFR Certified" });
            nuevo.Add(new Materia { Id = 37, TeacherId = 13, Nombre = "AutoCAD Architecture" });
            nuevo.Add(new Materia { Id = 38, TeacherId = 28, Nombre = "Behavioral Health" });
            nuevo.Add(new Materia { Id = 39, TeacherId = 5, Nombre = "Pension Funds" });
            nuevo.Add(new Materia { Id = 40, TeacherId = 22, Nombre = "HMC" });
            nuevo.Add(new Materia { Id = 41, TeacherId = 10, Nombre = "VDSL" });
            nuevo.Add(new Materia { Id = 42, TeacherId = 1, Nombre = "Full SDLC" });
            nuevo.Add(new Materia { Id = 43, TeacherId = 24, Nombre = "Dunn &amp; Bradstreet" });
            nuevo.Add(new Materia { Id = 44, TeacherId = 6, Nombre = "SV" });
            nuevo.Add(new Materia { Id = 45, TeacherId = 30, Nombre = "XATA" });
            nuevo.Add(new Materia { Id = 46, TeacherId = 24, Nombre = "Software Quality Assurance" });
            nuevo.Add(new Materia { Id = 47, TeacherId = 22, Nombre = "Behavior Based Safety" });
            nuevo.Add(new Materia { Id = 48, TeacherId = 18, Nombre = "Scanning Electron Microscopy" });
            nuevo.Add(new Materia { Id = 49, TeacherId = 28, Nombre = "Pallet Jack" });
            nuevo.Add(new Materia { Id = 50, TeacherId = 2, Nombre = "Go-to-market Strategy" });
            nuevo.Add(new Materia { Id = 51, TeacherId = 15, Nombre = "NCS" });
            nuevo.Add(new Materia { Id = 52, TeacherId = 7, Nombre = "Verilog" });
            nuevo.Add(new Materia { Id = 53, TeacherId = 27, Nombre = "Legislative Affairs" });
            nuevo.Add(new Materia { Id = 54, TeacherId = 9, Nombre = "PPMS" });
            nuevo.Add(new Materia { Id = 55, TeacherId = 4, Nombre = "Economic Research" });
            nuevo.Add(new Materia { Id = 56, TeacherId = 12, Nombre = "GMLAN" });
            nuevo.Add(new Materia { Id = 57, TeacherId = 27, Nombre = "ASP.NET MVC" });
            nuevo.Add(new Materia { Id = 58, TeacherId = 30, Nombre = "Piano" });
            nuevo.Add(new Materia { Id = 59, TeacherId = 1, Nombre = "GDS systems" });
            nuevo.Add(new Materia { Id = 60, TeacherId = 15, Nombre = "AVEVA PDMS" });
            nuevo.Add(new Materia { Id = 61, TeacherId = 17, Nombre = "EOC" });
            nuevo.Add(new Materia { Id = 62, TeacherId = 4, Nombre = "Radio Broadcasting" });
            nuevo.Add(new Materia { Id = 63, TeacherId = 19, Nombre = "JAX-WS" });
            nuevo.Add(new Materia { Id = 64, TeacherId = 22, Nombre = "Jitterbit" });
            nuevo.Add(new Materia { Id = 65, TeacherId = 26, Nombre = "Business Transformation" });
            nuevo.Add(new Materia { Id = 66, TeacherId = 24, Nombre = "CCDP" });
            nuevo.Add(new Materia { Id = 67, TeacherId = 12, Nombre = "Tour Management" });
            nuevo.Add(new Materia { Id = 68, TeacherId = 13, Nombre = "Quality Assurance" });
            nuevo.Add(new Materia { Id = 69, TeacherId = 2, Nombre = "JBoss Seam" });
            nuevo.Add(new Materia { Id = 70, TeacherId = 17, Nombre = "GFI" });
            nuevo.Add(new Materia { Id = 71, TeacherId = 15, Nombre = "SSPS" });
            nuevo.Add(new Materia { Id = 72, TeacherId = 25, Nombre = "LGD" });
            nuevo.Add(new Materia { Id = 73, TeacherId = 15, Nombre = "Cycling" });
            nuevo.Add(new Materia { Id = 74, TeacherId = 19, Nombre = "Test Planning" });
            nuevo.Add(new Materia { Id = 75, TeacherId = 11, Nombre = "European Affairs" });
            nuevo.Add(new Materia { Id = 76, TeacherId = 1, Nombre = "Biblical Studies" });
            nuevo.Add(new Materia { Id = 77, TeacherId = 20, Nombre = "JDE CNC" });
            nuevo.Add(new Materia { Id = 78, TeacherId = 30, Nombre = "UltraTax CS" });
            nuevo.Add(new Materia { Id = 79, TeacherId = 9, Nombre = "IB" });
            nuevo.Add(new Materia { Id = 80, TeacherId = 19, Nombre = "FCNSP" });
            nuevo.Add(new Materia { Id = 81, TeacherId = 6, Nombre = "Hydrology" });
            nuevo.Add(new Materia { Id = 82, TeacherId = 9, Nombre = "TVC" });
            nuevo.Add(new Materia { Id = 83, TeacherId = 5, Nombre = "Sea Kayaking" });
            nuevo.Add(new Materia { Id = 84, TeacherId = 21, Nombre = "NI LabVIEW" });
            nuevo.Add(new Materia { Id = 85, TeacherId = 1, Nombre = "SSAE 16" });
            nuevo.Add(new Materia { Id = 86, TeacherId = 13, Nombre = "GNU C" });
            nuevo.Add(new Materia { Id = 87, TeacherId = 22, Nombre = "Corporate Finance" });
            nuevo.Add(new Materia { Id = 88, TeacherId = 22, Nombre = "Inventory Management" });
            nuevo.Add(new Materia { Id = 89, TeacherId = 24, Nombre = "Geometric Dimensioning &amp; Tolerancing" });
            nuevo.Add(new Materia { Id = 90, TeacherId = 29, Nombre = "Project Oversight" });
            nuevo.Add(new Materia { Id = 91, TeacherId = 29, Nombre = "Beverage Industry" });
            nuevo.Add(new Materia { Id = 92, TeacherId = 10, Nombre = "AAUS Scientific Diver" });
            nuevo.Add(new Materia { Id = 93, TeacherId = 6, Nombre = "Freelance Writing" });
            nuevo.Add(new Materia { Id = 94, TeacherId = 4, Nombre = "VLSI" });
            nuevo.Add(new Materia { Id = 95, TeacherId = 12, Nombre = "Pygame" });
            nuevo.Add(new Materia { Id = 96, TeacherId = 13, Nombre = "Online Communications" });
            nuevo.Add(new Materia { Id = 97, TeacherId = 15, Nombre = "RIP" });
            nuevo.Add(new Materia { Id = 98, TeacherId = 17, Nombre = "Skin Care Products" });
            nuevo.Add(new Materia { Id = 99, TeacherId = 13, Nombre = "UCP" });
            nuevo.Add(new Materia { Id = 100, TeacherId = 14, Nombre = "Ghostwriting" });


            nuevingo.Add(new Profesor { Id = 1, Nombre= "Janet", Apellido = "Nelson", Edad = 41, Correo = "dnelson0@ft.com" });
            nuevingo.Add(new Profesor { Id = 2, Nombre= "Martha", Apellido = "Brooks", Edad = 42, Correo = "mbrooks1@msu.edu" });
            nuevingo.Add(new Profesor { Id = 3, Nombre= "Janice", Apellido = "Franklin", Edad = 44, Correo = "jfranklin2@cornell.edu" });
            nuevingo.Add(new Profesor { Id = 4, Nombre= "Martha", Apellido = "Burke", Edad = 26, Correo = "" });
            nuevingo.Add(new Profesor { Id = 5, Nombre= "Virginia", Apellido = "Williams", Edad = 50, Correo = "vwilliams4@wikispaces.com" });
            nuevingo.Add(new Profesor { Id = 6, Nombre= "Jonathan", Apellido = "Graham", Edad = 44, Correo = "" });
            nuevingo.Add(new Profesor { Id = 7, Nombre= "Helen", Apellido = "Snyder", Edad = 41, Correo = "hsnyder6@tuttocitta.it" });
            nuevingo.Add(new Profesor { Id = 8, Nombre= "George", Apellido = "Jackson", Edad = 21, Correo = "gjackson7@apple.com" });
            nuevingo.Add(new Profesor { Id = 9, Nombre= "Carol", Apellido = "Frazier", Edad = 38, Correo = "cfrazier8@taobao.com" });
            nuevingo.Add(new Profesor { Id = 10, Nombre= "Janet", Apellido = "Little", Edad = 38, Correo = "" });
            nuevingo.Add(new Profesor { Id = 11, Nombre= "Frank", Apellido = "Hunt", Edad = 24, Correo = "" });
            nuevingo.Add(new Profesor { Id = 12, Nombre= "Carl", Apellido = "Foster", Edad = 36, Correo = "cfosterb@harvard.edu" });
            nuevingo.Add(new Profesor { Id = 13, Nombre= "Margaret", Apellido = "Burton", Edad = 77, Correo = "" });
            nuevingo.Add(new Profesor { Id = 14, Nombre= "Carol", Apellido = "James", Edad = 30, Correo = "cjamesd@com.com" });
            nuevingo.Add(new Profesor { Id = 15, Nombre= "Shawn", Apellido = "Hanson", Edad = 40, Correo = "shansone@linkedin.com" });
            nuevingo.Add(new Profesor { Id = 16, Nombre= "Eugene", Apellido = "Stevens", Edad = 18, Correo = "estevensf@g.co" });
            nuevingo.Add(new Profesor { Id = 17, Nombre= "Maria", Apellido = "Myers", Edad = 23, Correo = "mmyersg@prnewswire.com" });
            nuevingo.Add(new Profesor { Id = 18, Nombre= "Terry", Apellido = "Williams", Edad = 26, Correo = "tlawrenceh@wiley.com" });
            nuevingo.Add(new Profesor { Id = 19, Nombre= "Phyllis", Apellido = "Burns", Edad = 33, Correo = "pburnsi@umn.edu" });
            nuevingo.Add(new Profesor { Id = 20, Nombre= "Emily", Apellido = "Robertson", Edad = 35, Correo = "erobertsonj@oracle.com" });
            nuevingo.Add(new Profesor { Id = 21, Nombre= "Janet", Apellido = "Gordon", Edad = 45, Correo = "cgordonk@barnesandnoble.com" });
            nuevingo.Add(new Profesor { Id = 22, Nombre= "Linda", Apellido = "Ramirez", Edad = 24, Correo = "lramirezl@bravesites.com" });
            nuevingo.Add(new Profesor { Id = 23, Nombre= "Lillian", Apellido = "Lynch", Edad = 39, Correo = "llynchm@thetimes.co.uk" });
            nuevingo.Add(new Profesor { Id = 24, Nombre= "Christopher", Apellido = "Jackson", Edad = 54, Correo = "" });
            nuevingo.Add(new Profesor { Id = 25, Nombre= "Laura", Apellido = "Williams", Edad = 67, Correo = "" });
            nuevingo.Add(new Profesor { Id = 26, Nombre= "William", Apellido = "Allen", Edad = 16, Correo = "wallenp@army.mil" });
            nuevingo.Add(new Profesor { Id = 27, Nombre= "Henry", Apellido = "Arnold", Edad = 33, Correo = "harnoldq@exblog.jp" });
            nuevingo.Add(new Profesor { Id = 28, Nombre= "Nancy", Apellido = "Peters", Edad = 39, Correo = "npetersr@engadget.com" });
            nuevingo.Add(new Profesor { Id = 29, Nombre= "Janet", Apellido = "Torres", Edad = 50, Correo = "storress@npr.org" });
            nuevingo.Add(new Profesor { Id = 30, Nombre = "Ruth", Apellido = "Williams", Edad = 26, Correo = "rbishopt@ezinearticles.com" });
        }
    }
}
