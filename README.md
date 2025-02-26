# Unity dialog system

## Description
Easy dialog system using the EventBus. All dialogs will appear in the order they were invoked no mather what script invoked them.

## Example usage

Drag the VR_Canvas prefab (containing the DialogManager.cs) in the scene.

Example usage

```csharp 
public class ExampleMonoBehaviour : MonoBehaviour
    {        
        private void Start()
        {
           ShowDialogs();
        }
        
        private void ShowDialogs()
        {
            EventBus<DialogRequest>.Raise(new DialogRequest(
                "Info", "This is a info dialog with one button.", DialogType.Info,
                () => Debug.Log("Info button clicked")
                ));
            
            EventBus<DialogRequest>.Raise(new DialogRequest(
                "Yes no dialog", "This is a Yes or No dialog with two buttons.", DialogType.YesNo,
                () => Debug.Log("Yes button clicked"),
                () => Debug.Log("No button clicked")
            ));
            
            EventBus<DialogRequest>.Raise(new DialogRequest(
                "Yes no cancel dialog", "This is a Yes, No or Cancel dialog with three buttons.", DialogType.YesNoCancel,
                () => Debug.Log("Yes button clicked"),
                () => Debug.Log("No button clicked"),
                () => Debug.Log("Cancel button clicked")
            ));
        } 
```

# Extension Classes

## Description
Helper extension classes to use with BNG Framework.

## Example usage

```csharp 
        private void LockExample()
        {
            grabbable.LockGrabbable;
            snapZone.LockSnapzone;
        } 
        
        private void UnlockExample() 
        {
            grabbable.UnlockGrabbable;
            snapZone.UnlockSnapzone;
        }
```

# Tighten with tool mechanism

## Description
Snap and tighten mechanism using Grabbable and Snapzone.

### Fields 
```csharp
SnapZone toolSnapzoneToCheck
Lever lever
Grabbable hingeGrabbable
```

### Events
```csharp
public event Action<TightenType> OnTighteningStatusModified; 
public event Action<ToolInstallation> OnWrenchStatusModified;
```
