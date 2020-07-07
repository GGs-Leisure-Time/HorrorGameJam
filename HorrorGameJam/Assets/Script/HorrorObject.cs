using UnityEngine;

public class HorrorObject : MonoBehaviour
{
    public virtual void TriggerEvent()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player") TriggerEvent();
    }

}
