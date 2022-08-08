import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { IRecipe } from "./recipe.interface";

@Injectable()
export class RecipeService {
    private readonly apiUrl: string = 'http://localhost:4200/api/recipe';

    constructor(private httpClient: HttpClient) {
    }

    public addRecipe(recipe: IRecipe): Observable<null> {
        return this.httpClient.post<null>(`${this.apiUrl}/create`, recipe);
    }
    
    public deleteRecipe(id: number): Observable<object> {
        return this.httpClient.delete(`${this.apiUrl}/${id}/delete`);
    }

    public getRecipes(): Observable<IRecipe[]> {
        return this.httpClient.get<IRecipe[]>(`${this.apiUrl}/get-all`);
    }

    public getRecipe(id: number): Observable<IRecipe> {
        return this.httpClient.get<IRecipe>(`${this.apiUrl}/${id}`);
    }

    public updateRecipe(recipe: IRecipe): Observable<null> {
        return this.httpClient.post<null>(`${this.apiUrl}/update`, recipe);
    }
}