//imports
using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    //variables 
    public Camera cami;
    public NavMeshAgent fred;
    bool isMoving = false;
    // Update is called once per frame
    void Update()
    {

        //checking if left mouse button was pressed down
        if (Input.GetMouseButtonDown(0))
        {
            /*Raycasts used to make connections between objects in Unity
             * 
             * Ray is a datastruck in unity that represents a point of origin 
             * and a direction for the ray to travel. 
             * 
             * Physics funct that projects a ray into the scene, returns bool 
             * if a target was sucessfully hit. If true info about hit is returned,
             * i.e. distance, position or a refrence to the object's transform. This 
             * info is stored in a RaycastHit variable for further use
            */


            //converts the information of the cursor position into a ray-type
            Ray ray = cami.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            //saves the data from the generated ray as a RaycastHit
            ////and check if a hitable item was selected
            if (Physics.Raycast(ray, out hit) && !isMoving)
            {
                Debug.Log("hit registered"); 
                //move our agent using it's movement feature
                fred.SetDestination(hit.point);
                //isMoving = true; 
            }



        }
    }
}
