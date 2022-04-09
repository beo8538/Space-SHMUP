/**** 
 * Created by: Betzaida Ortiz Rivas
 * Date Created: 4/8/2022
 * 
 * Last Edited by: 
 * Last Edited:
 * 
 * Description: Behaviours for the projectile
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolReturn : MonoBehaviour
{
    /**Variables**/
    private ObjectPool pool;

    // Start is called before the first frame update
    void Start()
    {
        pool = ObjectPool.POOL; // find the game manager

    }//end Start()

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        //if the pool is not empty
        if(pool != null)
        {
            pool.ReturnObject(this.gameObject); //return to pool
        } //end if-statement
    }//end OnDisable()

}
