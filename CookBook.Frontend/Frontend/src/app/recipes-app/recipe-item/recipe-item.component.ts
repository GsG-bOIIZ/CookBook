import {Component, Input, OnInit} from '@angular/core';
import {IRecipe} from "../shared/recipe.interface";

@Component({
  selector: 'app-recipe-item',
  templateUrl: './recipe-item.component.html',
  styleUrls: ['./recipe-item.component.css']
})
export class RecipeItemComponent implements OnInit {

  @Input() public recipe!: IRecipe;
  
  constructor() { }

  ngOnInit(): void {
  }

}
