using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientDublicate : MonoBehaviour
{
    public Transform table;

    public void createIngredient(GameObject duplicatePrefab) {
        GameObject duplicateObject = Instantiate(duplicatePrefab, table.position, table.rotation);
    }
    
}
