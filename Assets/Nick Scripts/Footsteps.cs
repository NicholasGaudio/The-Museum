using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] woodFootstepClips;
    public AudioClip[] carpetFootstepClips;
    public AudioClip[] grassFootstepClips;
    public AudioClip[] metalFootstepClips;
    public AudioClip[] dockFootstepClips;
    public AudioClip[] brickFootstepClips;
    public AudioClip[] dirtFootstepClips;
    public AudioClip[] pathFootstepClips;



    public float stepInterval = 0.5f; // Time between footsteps

    private float lastStepTime = 0f;
    private int lastClipIndex = -1; // Store the index of the last played clip

    void Update()
    {
        if (IsMoving() && Time.time - lastStepTime > stepInterval)
        {
            PlayFootstepSound();
            lastStepTime = Time.time;
        }
    }

    private bool IsMoving()
    {
        // Check for player movement
        return Mathf.Abs(Input.GetAxis("Horizontal")) > 0.1f || Mathf.Abs(Input.GetAxis("Vertical")) > 0.1f;
    }

    private void PlayFootstepSound()
    {
        // Raycast to determine the material the player is walking on
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 2f))
        {
            string tag = hit.collider.tag;

            AudioClip[] selectedClips = null;

            switch (tag)
            {
                case "Wood":
                    selectedClips = woodFootstepClips;
                    break;
                case "Grass":
                    selectedClips = grassFootstepClips;
                    break;
                case "Metal":
                    selectedClips = metalFootstepClips;
                    break;
                case "Carpet":
                    selectedClips = carpetFootstepClips;
                    break;
                case "Brick":
                    selectedClips = brickFootstepClips;
                    break;
                case "Dock":
                    selectedClips = dockFootstepClips;
                    break;
                case "Dirt":
                    selectedClips = dirtFootstepClips;
                    break;
                case "Path":
                    selectedClips = pathFootstepClips;
                    break;
                default:
                    return; // No sound for unrecognized tags
            }

            if (selectedClips != null && selectedClips.Length > 0)
            {
                int clipIndex;
                do
                {
                    clipIndex = Random.Range(0, selectedClips.Length);
                } while (clipIndex == lastClipIndex); // Ensure the new clip is different

                lastClipIndex = clipIndex; // Update the last played clip index
                audioSource.PlayOneShot(selectedClips[clipIndex]);
            }
        }
    }
}
