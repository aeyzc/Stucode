using Stucode.Scripts.Abstracts.Item;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stucode.Scripts.Concretes.Item
{
    public class MovableItem : BaseItem
    {
        GameObject mainCamera;
        GameObject carryHintPanel;
        public float objectDistance = 3f;
        float transitionSoftness=15f,rotateSpeed=5f, countdown = 0, throwSpeed = 750f, carribletransportableDistance=7f;
        [SerializeField] float maxDistance = 5f, minDistance = 2f, defDistance = 3;
        Rigidbody objectRb;
        Collider objectCollider;
        bool letCount;
        public bool isHolding;

        private void Start()
        {
            carryHintPanel = GameObject.Find("Canvas").transform.GetChild(2).gameObject;
            objectRb=gameObject.GetComponent<Rigidbody>();
            objectCollider=gameObject.GetComponent<Collider>();
            mainCamera = GameObject.Find("CharacterCamera");
        }
        private void Update()
        {
            if (isHolding) carryItem();

            if (letCount)
            {
                countdown += Time.deltaTime;

                if (countdown > 1)
                {
                    PlayerController.Instance.isCarrying = false;
                    letCount = false;
                    countdown = 0;
                }

            }
        }

        private void FixedUpdate()
        {
            if (isHolding) carryItemForFixedUpdate();
        }

        void carryItemForFixedUpdate()
        {
            if (!PlayerController.Instance.isHandCollision)
            {
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, mainCamera.transform.position + mainCamera.transform.forward * objectDistance, Time.deltaTime * transitionSoftness);
            }

        }

        void carryItem()
        {
            if (Input.GetKeyUp(KeyCode.F) && isHolding) ReleaseItem(false);
            if (Input.GetAxis("Mouse ScrollWheel") > 0f && objectDistance < maxDistance) objectDistance += 0.5f;
            else if (Input.GetAxis("Mouse ScrollWheel") < 0f && objectDistance > minDistance) objectDistance -= 0.5f;
            if (Input.GetMouseButton(1)) rotateItem();
            if (Input.GetMouseButtonDown(0)) throwItem();
            if (PlayerController.Instance.isHandCollision && Vector3.Distance(transform.position, PlayerController.Instance.gameObject.transform.position)> carribletransportableDistance) 
                ReleaseItem(false);


        }

        void rotateItem()
        {
            PlayerController.Instance.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            gameObject.transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * rotateSpeed, 0));
            gameObject.transform.Rotate(new Vector3(0, 0, Input.GetAxis("Mouse Y") * rotateSpeed));
        }

        void throwItem()
        {
            ReleaseItem(true);
            objectRb.AddForce((mainCamera.transform.forward* throwSpeed) * (objectRb.mass));
            

        }
        void takeItem()
        {
            carryHintPanel.SetActive(true);
            objectCollider.isTrigger = true;
            objectRb.isKinematic = true;
            isHolding = true;
            gameObject.layer = 2;
            PlayerController.Instance.isCarrying = true;
            PlayerController.Instance.carryingItem = this;
        }

        

        void ReleaseItem(bool isThrowed)
        {
            carryHintPanel.SetActive(false);
            objectRb.isKinematic = false;
            objectCollider.isTrigger = false;
            isHolding = false;
            gameObject.layer = 0;
            objectDistance = defDistance;
            PlayerController.Instance.carryingItem = null;
            if (isThrowed) letCount = true;
            else
            {
                PlayerController.Instance.isCarrying = false;
                objectRb.velocity = Vector3.zero;
            }
        }

        public override void InteractToItem()
        {
            takeItem();
        }
    }
}


