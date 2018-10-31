/**********************************************************
 * 
 * Bullet.cs
 * - moves the bullet and does damage to any GameObject it hits
 * - if the bullet hits nothing and moves off screen it is destroyed
 * - if the bullet hits something, it will attempt to apply the damage, then destroy itself
 * 
 * 
 * public variables
 * - moveSpeed
 *   - the speed the bullet will move at
 *   
 * - damage
 *   - an int for how much damage will be applied to the GameObject the bullet hits
 *   
 *   
 * private custom methods
 * - Die
 *   - Destroys the bullet using the Destroy method
 *   - see link: https://docs.unity3d.com/ScriptReference/Object.Destroy.html
 *   
 * 
 **********************************************************/

using UnityEngine;


/*
 * Require component
 * this is an "Attribute"
 * We will be using a Rigidbody2D component in this script.
 * To guarantee we will have a Rigidbody2D component on our bullet GameObject, 
 * we can use RequireComponent. 
 * This will add a Rigidbody2D component to our GameObject automatically if we put this script onto the bullet
 * We can do this for any other type of component.
 * We can even add more than one RequireComponent for different components if we need to!
 * see link: https://docs.unity3d.com/ScriptReference/RequireComponent.html
 */
[RequireComponent(typeof(Rigidbody2D))]


public class Bullet : MonoBehaviour
{
   


  
    public float moveSpeed = 100;


    public int damage = 1;




   
    private void Start()
    {
       
        
        Vector3 facingDirection = transform.up;


     
     
        Vector3 velocity = facingDirection * moveSpeed;

        
       
        GetComponent<Rigidbody2D>().AddForce(velocity);
    }


   
    private void OnTriggerEnter2D(Collider2D other)
    {
       
        string methodName = "TakeDamage";


       
        SendMessageOptions messageOptions = SendMessageOptions.DontRequireReceiver;


        Transform hitObject = other.transform;


       
        hitObject.SendMessage(methodName, damage, messageOptions);


        Die();
    }


   
    private void OnBecameInvisible()
    {
        
        Die();
    }


  
    private void Die()
    {
       
        Destroy(gameObject);
    }
}
