﻿using System.Collections.Generic;

namespace WebApplication.Models
{
    public class ComponentType
    {
        public ComponentType()
        {
            Components = new List<Component>();
            CategoryComponentTypes = new List<CategoryComponentType>();
        }

        public long ComponentTypeId { get; set; }
        public string ComponentName { get; set; }
        public string ComponentInfo { get; set; }
        public string Location { get; set; }
        public ComponentTypeStatus Status { get; set; }
        public string Datasheet { get; set; }
        public string ImageUrl { get; set; }
        public string Manufacturer { get; set; }
        public string WikiLink { get; set; }
        public string AdminComment { get; set; }
        public virtual ESImage Image { get; set; }
        public ICollection<Component> Components { get; protected set; }
        public ICollection<CategoryComponentType> CategoryComponentTypes { get; protected set; }
    }
}