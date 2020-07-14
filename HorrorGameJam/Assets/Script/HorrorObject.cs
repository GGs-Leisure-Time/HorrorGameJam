using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class HorrorObject : MonoBehaviour
{
    private Rigidbody rig;

    private void Awake()
    {
        rig = GetComponent<Rigidbody>();
        rig.useGravity = false;
        //凍結全部
        rig.constraints = RigidbodyConstraints.FreezeAll;
    }

    public virtual void TriggerEvent()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player") TriggerEvent();
    }

}
