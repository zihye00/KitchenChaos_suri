using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu()] -> 1개만 필요해서 만들고 지움
public class RecipeListSO : ScriptableObject
{
    public List<RecipeSO> recipeSOList;
}
