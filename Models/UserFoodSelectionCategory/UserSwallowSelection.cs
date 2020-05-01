﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodPlanner.Models.UserFoodSelectionCategory
{
    public class UserSwallowSelection
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [Required(ErrorMessage = "Select an option")]
        [Display(Name = "Swallow")]
        public int UserSwallowId { get; set; }
    }
}
