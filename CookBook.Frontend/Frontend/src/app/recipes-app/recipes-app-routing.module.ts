import { RouterModule, Routes } from "@angular/router";
import { NgModule } from "@angular/core";
import {RecipePageComponent} from "./recipe-page/recipe-page.component";
import {RecipesPageComponent} from "./recipes-page/recipes-page.component";

const routes: Routes = [
    {
        path: 'recipe',
        component: RecipePageComponent
    },
    {
        path: 'recipes',
        component: RecipesPageComponent
    }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class RecipesAppRoutingModule { }
