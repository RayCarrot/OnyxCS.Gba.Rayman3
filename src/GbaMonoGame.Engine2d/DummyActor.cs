using GbaMonoGame.TgxEngine;

namespace GbaMonoGame.Engine2d;

// Temporary class

// TEST: Force to ActionActor so hitboxes show for not-implemented actors too
public class DummyActor : ActionActor
{
    public DummyActor(int instanceId, Scene2D scene, ActorResource actorResource) : base(instanceId, scene, actorResource)
    {
        Logger.NotImplemented("Not implemented actor of type {0}", actorResource.Type);

        if (actorResource.FirstActionId < actorResource.Model.Actions.Length)
            AnimatedObject.CurrentAnimation = actorResource.Model.Actions[actorResource.FirstActionId].AnimationIndex;
        else
            AnimatedObject.CurrentAnimation = actorResource.FirstActionId;

        if (Scene.Playfield is TgxPlayfieldMode7)        
            AnimatedObject.BgPriority = 0;
    }
}