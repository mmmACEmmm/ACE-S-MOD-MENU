using System;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal static class MovementHelper
    {
        // New field for ground height
        private static float groundHeight = 0.0f; // Adjust this value as necessary

        // Hand movement stages
        private enum HandMovementStage
        {
            Raise,
            MoveForward,
            Lower
        }

        private static HandMovementStage rightHandStage = HandMovementStage.Raise;
        private static HandMovementStage leftHandStage = HandMovementStage.Raise;

        // Adjust timing and distances as necessary
        private static float handRaiseHeight = 0.2f;
        private static float handMoveDistance = 2.0f;
        private static float handMovementSpeed = 1.0f;

        public static void MoveHands()
        {
            if (!ControllerInputPoller.instance.rightGrab && !ControllerInputPoller.instance.leftGrab)
                return;

            float time = Time.time;

            // Update hand positions based on their current stage
            UpdateHandPosition(ref rightHandStage, GorillaTagger.Instance.rightHandTransform, time);
            UpdateHandPosition(ref leftHandStage, GorillaTagger.Instance.leftHandTransform, time + MathF.PI); // Slight offset for alternating movement
        }

        private static void UpdateHandPosition(ref HandMovementStage handStage, Transform handTransform, float time)
        {
            Vector3 basePosition = new Vector3(
                GorillaTagger.Instance.headCollider.transform.position.x,
                groundHeight,
                GorillaTagger.Instance.headCollider.transform.position.z
            );

            Vector3 forward = GorillaTagger.Instance.headCollider.transform.forward;
            Vector3 right = GorillaTagger.Instance.headCollider.transform.right;

            switch (handStage)
            {
                case HandMovementStage.Raise:
                    handTransform.position = new Vector3(
                        basePosition.x,
                        groundHeight + handRaiseHeight,
                        basePosition.z
                    );
                    if (MathF.Sin(time * handMovementSpeed) > 0)
                    {
                        handStage = HandMovementStage.MoveForward;
                    }
                    break;

                case HandMovementStage.MoveForward:
                    handTransform.position = new Vector3(
                        basePosition.x + (forward * handMoveDistance).x,
                        groundHeight + handRaiseHeight,
                        basePosition.z + (forward * handMoveDistance).z
                    );
                    if (MathF.Sin(time * handMovementSpeed) < 0)
                    {
                        handStage = HandMovementStage.Lower;
                    }
                    break;

                case HandMovementStage.Lower:
                    handTransform.position = new Vector3(
                        basePosition.x + (forward * handMoveDistance).x,
                        groundHeight,
                        basePosition.z + (forward * handMoveDistance).z
                    );
                    if (MathF.Sin(time * handMovementSpeed) > 0)
                    {
                        handStage = HandMovementStage.Raise;
                    }
                    break;
            }
        }

        public static void MoveHead(float speed)
        {
            if (!ControllerInputPoller.instance.rightGrab && !ControllerInputPoller.instance.leftGrab)
                return;

            Vector3 headForward = GorillaTagger.Instance.headCollider.transform.forward;
            GorillaTagger.Instance.headCollider.transform.position += headForward * speed * Time.deltaTime;
        }
    }

    internal class AutooWalk
    {
        private static float walkSpeed = 0.04f; // Adjust this value for walking speed

        public static void Execute()
        {
            MovementHelper.MoveHands();
            MovementHelper.MoveHead(walkSpeed);
        }
    }

    internal class AutooRun
    {
        private static float runSpeed = 0.7f; // Adjust this value for running speed

        public static void Execute()
        {
            MovementHelper.MoveHands();
            MovementHelper.MoveHead(runSpeed);
        }
    }
}
