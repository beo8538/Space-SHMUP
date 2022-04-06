/**** 
 * Created by: Betzaida Ortiz Rivas
 * Date Created: 4/6/2022
 * 
 * Last Edited by: 
 * Last Edited:
 * 
 * Description: Create a pool of object for reuse
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    /**Variables**/
    static public ObjectPool POOL;

    #region POOL Singleton
    void CheckPoolIsInScene()
    {
        if(POOL == null)
        {
            POOL = this;
        }
        else
        {
            Debug.LogError("POOL.Awake() - Attempted to assign a second Object.POOL");
        }
    } //end CheckPoolIsInScene()
    #endregion

    private Queue<GameObject> projectiles = new Queue<GameObject>(); //new queue of projectiles

    [Header("POOL Settings")]
    public GameObject projectilePrefab;
    public int poolStartSize = 5;

    /**Methods**/
    private void Awake()
    {
        CheckPoolIsInScene();
    } //end Awake()

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
