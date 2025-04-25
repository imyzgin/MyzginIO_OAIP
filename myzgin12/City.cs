﻿using Supabase.Postgrest.Models;
using Supabase.Postgrest.Attributes;

namespace myzgin12
{
    public class City : BaseModel
    {
        [PrimaryKey("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }

    }
}
