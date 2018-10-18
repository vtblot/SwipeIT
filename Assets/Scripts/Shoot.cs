using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
	[SerializeField] Transform bulletSpawn;
	[SerializeField] GameObject bulletPrefab;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

			if (hit.collider != null)
			{
				Vector2 dir = (hit.collider.gameObject.transform.position - transform.position).normalized;
				float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
				Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
				transform.rotation = Quaternion.Slerp(transform.rotation, q, 0.5f);
				GameObject bul = Instantiate(bulletPrefab, bulletSpawn.position, q);
			
			}

		}
	}
}

	
