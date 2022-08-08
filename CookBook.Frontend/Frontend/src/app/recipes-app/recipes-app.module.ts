import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {MatTabsModule} from '@angular/material/tabs';
import {MatButtonModule} from "@angular/material/button";
import {MatCardModule} from "@angular/material/card";
import {MatInputModule} from '@angular/material/input';
import {HttpClientModule} from "@angular/common/http";
import {ReactiveFormsModule} from "@angular/forms";
import {RecipesAppRoutingModule} from "./recipes-app-routing.module";
import { RecipeItemComponent } from './recipe-item/recipe-item.component';
import { RecipesPageComponent } from './recipes-page/recipes-page.component';
import { RecipePageComponent } from './recipe-page/recipe-page.component';
import {MatChipsModule} from '@angular/material/chips';


@NgModule({
  declarations: [
    RecipeItemComponent,
    RecipesPageComponent,
    RecipePageComponent
  ],
  imports: [
    CommonModule,
    RecipesAppRoutingModule,
    MatTabsModule,
    MatButtonModule,
    MatCardModule,
    HttpClientModule,
    MatInputModule,
    ReactiveFormsModule,
    MatChipsModule
  ]
})
export class RecipesAppModule {
}
