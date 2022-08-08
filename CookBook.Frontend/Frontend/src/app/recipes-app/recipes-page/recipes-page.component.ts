import { Component, OnInit } from '@angular/core';
import {IRecipe} from "../shared/recipe.interface";
import {RecipeService} from "../shared/recipe.service";

@Component({
  selector: 'app-recipes-page',
  templateUrl: './recipes-page.component.html',
  styleUrls: ['./recipes-page.component.css'],
  providers: [ RecipeService ]
})
export class RecipesPageComponent implements OnInit {

  public recipes: IRecipe[] = [/*
    {
      id: 1,
      tags: ["десерты", "клубника", "сливки", "десерты", "клубника", "сливки"],
      stars: 10,
      likes: 8,
      title: "Клубничная панна-котта",
      description: "Десерт, который невероятно легко и быстро готовится. " +
                   "Советую подавать его порционно в красивых бокалах, " +
                   "украсив взбитыми сливками, свежими ягодами и мятой.",
      cookingTime: 35,
      portions: 5
    },
    {
      id: 2,
      tags: ["вторые блюда", "мясо", "соевый соус"],
      stars: 4,
      likes: 7,
      title: "Мясные фрикадельки",
      description: "Мясные фрикадельки в томатном соусе - несложное и вкусное блюдо," +
                   " которым можно порадовать своих близких. ",
      cookingTime: 90,
      portions: 4
    }*/
  ];
  
  constructor(private recipeService: RecipeService) { }

  ngOnInit(): void {
    this.updateInfo();
  }

  public updateInfo() {
    this.recipeService.getRecipes().subscribe((raw) => this.recipes = raw);
  }
}
