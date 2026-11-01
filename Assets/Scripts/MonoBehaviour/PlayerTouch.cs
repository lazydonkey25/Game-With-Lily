#region Libraries
using UnityEngine;
#endregion

#region Dependencies
[RequireComponent(typeof(BoxCollider2D))]
#endregion

public class PlayerTouch : MonoBehaviour
{
    #region Variables
    private BoxCollider2D boxCollider2D;
    #endregion

    #region Unity Methods
    void Start()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        GameObject otherObject = collider2D.gameObject;

        if (otherObject.CompareTag("InteractableObject"))
        {
            InteractableObject interactableObject = otherObject.GetComponent<InteractableObject>();
        }
    }
    #endregion
}
