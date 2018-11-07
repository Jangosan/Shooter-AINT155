/*******************************************************
 * 
 * SmoothFollow2D.cs
 *  - follows the transform of another GameObject
 *  - uses a smoothing variable to animate movement over time
 * 
 * 
 * 
 * public variables:
 *  - target
 *    - the transform of the GameObject to follow
 *    
 *  - smoothing
 *    - the speed of movement towards the target transform
 *    
 *    
 * private variables: none
 *    
 *    
 * Monobehaviour methods
 *  - FixedUpdate
 *    - runs contantly at a fixed time step
 *    - only runs while this script is active
 *    - see link: https://docs.unity3d.com/ScriptReference/MonoBehaviour.FixedUpdate.html
 * 
 * 
 *******************************************************/
using UnityEngine;
 
public class SmoothFollow2D : MonoBehaviour
{
   
    public Transform target;


    public float smoothing = 5.0f;


   
    void FixedUpdate()
    {
       
        Vector3 currentPosition = transform.position;


        
        Vector3 targetPosition = target.position;


      
        float moveSpeed = smoothing * 0.001f;


        
        Vector3 newPosition = new Vector3();


     
        newPosition.x = targetPosition.x;


        
        newPosition.y = targetPosition.y;

        
        newPosition.z = currentPosition.z;


        
        transform.position = Vector3.Lerp(currentPosition, newPosition, moveSpeed);
    }
}
