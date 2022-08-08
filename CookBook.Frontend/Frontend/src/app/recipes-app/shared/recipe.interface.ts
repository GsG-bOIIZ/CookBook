export interface IRecipe {
    id: number;
    tags: string[];
    stars: number;
    likes: number;
    title: string;
    description: string;
    cookingTime: number;
    portions: number;    
}