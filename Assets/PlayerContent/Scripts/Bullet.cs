using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public WeaponTypes WeaponType { get; set; }

    // Update is called once per frame
    private void Update()
    {
        if(Physics.Raycast(new Ray(transform.position, transform.forward), out RaycastHit hit, WeaponType.velocity * Time.deltaTime))
        {
            transform.position = hit.point;
            hit.collider.SendMessage("Damaged", WeaponType.damage, SendMessageOptions.DontRequireReceiver);
            GetComponent<MeshRenderer>().enabled = false;
            Destroy(gameObject, 1f);
            Destroy(this);
        }
        else
        {
            transform.Translate(Vector3.forward * WeaponType.velocity *Time.deltaTime);
        }
    }
}
