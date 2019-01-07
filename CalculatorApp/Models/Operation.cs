using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CalculatorApp.Models
{
    public class Operation
    {
        [Required(ErrorMessage = "Numeric Value is required")]
        public double InputA { get; set; }

        public double InputB { get; set; }

        public Function InputFunc { get; set; }

        public string SelectedFunction { get; set; }

        public string Answer { get; set; }
    }

    public enum Function{
        Add,
        Subtract,
        Multiply,
        Divide,
        Sin,
        Cos,
        Tan,
        Atan,
        Sqrt,
        Power
    }


}