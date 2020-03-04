using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestDB
{
    class TestModel
    {
        [Key]
        public int TestId { get; set; }
        public String TestName { get; set; }
        public String TestDescription { get; set; }
    }
}
