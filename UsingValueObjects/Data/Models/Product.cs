using System;
using UsingValueObjects.Data.Models;

namespace UsingValueObjects
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Manufacture { get; set; }
        public Money Price { get; set; }
    }
}