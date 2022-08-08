﻿namespace CookBook.Api.Dto
{
    public class RecipeDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CookingTime { get; set; }
        public int Portions { get; set; }
        public int Stars { get; set; }
        public int Likes { get; set; }
    }
}
