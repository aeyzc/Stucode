using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CameraControl : MonoBehaviour
{
	Image cross;
	PlayerController playerController;
	Animator cameraAnimator;
	
	
	float softness = 1f;
		
	Vector2 transitionPosition;
	Vector2 cameraPosition;

	GameObject player;

	void Start()
	{
		cameraAnimator = gameObject.GetComponent<Animator>();
		player = transform.parent.gameObject;
	}

	
	void FixedUpdate()
	{
		cameraAnimator.SetBool("isWalking", PlayerController.Instance.isWalking && PlayerController.Instance.isOnFloor && GameManager.Instance.isGameActive);


		if (GameManager.Instance.isGameActive && (!Input.GetMouseButton(1) || !PlayerController.Instance.isCarrying)) { 
			Vector2 mousePosition = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
			mousePosition = Vector2.Scale(mousePosition, new Vector2(PlayerPrefs.GetFloat("mouseSens") * softness, PlayerPrefs.GetFloat("mouseSens") * softness));
			transitionPosition.x = Mathf.Lerp(transitionPosition.x, mousePosition.x, 1f / softness);
			transitionPosition.y = Mathf.Lerp(transitionPosition.y, mousePosition.y, 1f / softness);
			cameraPosition += transitionPosition;
			cameraPosition.y= Mathf.Clamp(cameraPosition.y, -90, 90);
			transform.localRotation = Quaternion.AngleAxis(-cameraPosition.y, Vector3.right);
			player.transform.localRotation = Quaternion.AngleAxis(cameraPosition.x, player.transform.up);
		}

		


	}



}
