using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    // [SerializeField] private bool useFootsteps = true;


    // [Header("Footstep Parameters")]
    // [SerializeField] private float baseStepSpeed = 0.5f;
    // [SerializeField] private float crouchStepMultiplier = 1.5f;
    // [SerializeField] private float sprintStepMultiplier = 0.6f;
    // [SerializeField] private AudioSource footstepAudioSource = default;
    // [SerializeField] private AudioClip[] concreteClips = default;
    // [SerializeField] private AudioClip[] tennisClips = default;
    // [SerializeField] private AudioClip[] blockClips = default;
    // private float footstepTimer = 0;
    // private float GetCurrentOffset => isCrouching ? baseStepSpeed * crouchStepMultiplier : isSprinting ? baseStepSpeed * sprintStepMultiplier : baseStepSpeed;

    // // Update is called once per frame
    // void Update()
    // {

    //     if (useFootsteps)
    //         Handle_Footsteps();



    //     // if(velocity.magnitude >= 1){
    //     //     footstepTimer += Time.deltaTime;

    //     //     float seconds = footstepTimer % 60;
    //     //     if(seconds >= 0.8){
    //     //         FootstepAudioSource.PlayOneShot(concreteClips[Random.Range(0, concreteClips.Length -1)]);
    //     //         footstepTimer = 0;

    //     //     }

    //     // }  
    // }

    // private void Handle_Footsteps()
    // {
    //     if(!CharacterController.isGrounded) return;
    //     if(currentInput == Vector2.zero) return;

    //     footstepTimer -= Time.deltaTime;

    //     if(footstepTimer <= 0);
    //     {
    //         if(Physics.Raycast(playerCamera.transform.position, Vector3.down, out Raycast hit, 3))
    //         {
    //             switch(hit.collider.tag)
    //             {
    //                 case "Footsteps/TENNIS":
    //                     footstepAudioSource.PlayOneShot(tennisClips[Random.Range(0, tennisClips.Length - 1)]);
    //                     break;
    //                 case "Footsteps/CONCRETE":
    //                     footstepAudioSource.PlayOneShot(concreteClips[Random.Range(0, concreteClips.Length - 1)]);
    //                     break;
    //                 case "Footsteps/BLOCK":
    //                     footstepAudioSource.PlayOneShot(blockClips[Random.Range(0, blockClips.Length - 1)]);
    //                     break;
    //                 default:
    //                     footstepAudioSource.PlayOneShot(blockClips[Random.Range(0, blockClips.Length - 1)]);
    //                     break;
    //             }
    //         }
    //         footstepTimer = GetCurrentOffset;
    //     }
    // }
}
