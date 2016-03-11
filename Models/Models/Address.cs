using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
using System.ComponentModel;

namespace Models
{
    
    public class Address :BaseModel
    {
        public Address()
        {
           
        }

        
        [Display(Name ="Address 1",Prompt ="Address 1")]
        public string Address1 { get; set; }

        [Display(Name = "Address 2", Prompt = "Address 2")]
        public string Address2 { get; set; }

        
        public string City { get; set; }

       
        public string State { get; set; }


        public string StateCode { get { return States.GetCodeFor(State); } }

        
        
        [Remote("IsValidZipCode", "RemoteValidations", ErrorMessage = "{0} Is not Valid")]

        [RegularExpression("^[0-9]*$", ErrorMessage = "ZipCode must be numeric")]
        [Display(Name ="Zip")]
        [DisplayName("Zip")]

        public string Zip { get; set; }
    

        
        public string FullAddress
        {
            get { return string.Format("{0} {1} {2} {3} ", Address1, Address2, City, State, Zip); }
        } 

        public string AddressPart1
        {
            get { return string.Format("{0} {1}", Address1, Address2); }
        }

        public string AddressPart2
        {
            get { return string.Format("{0} {1} {2}", City, State,Zip); }
        }
       
         
    }

}
