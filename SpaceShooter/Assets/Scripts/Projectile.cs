/**** 
 * Created by: Betzaida Ortiz Rivas
 * Date Created: 4/6/2022
 * 
 * Last Edited by: 
 * Last Edited:
 * 
 * Description: Behaviours for the projectile
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    /**Variables**/
    private BoundsCheck bndCheck; //ref to boundary

    // Start is called before the first frame update
    void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bndCheck.offUp)
        {
            Destroy(gameObject);
        }
    }
}
