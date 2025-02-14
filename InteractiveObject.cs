using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InteractiveObject : XRGrabInteractable
{
    public string objectName;
    public bool isActive;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        Debug.Log($"{objectName} взят в руку.");
    }

    public virtual void Activate()
    {
        isActive = true;
    }

    public virtual void Deactivate()
    {
        isActive = false;
    }
}
