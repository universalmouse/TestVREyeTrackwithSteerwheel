using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace NWH.VehiclePhysics2.GroundDetection
{
    /// <summary>
    ///     A ScriptableObject representing a set of SurfaceMaps. Usually one per scene or project.
    /// </summary>
    [Serializable]
    [CreateAssetMenu(fileName = "NWH Vehicle Physics", menuName = "NWH Vehicle Physics/Ground Detection Preset",
                     order    = 1)]
    public class GroundDetectionPreset : ScriptableObject
    {
        /// <summary>
        ///     Prefab of the particle system for generating dust (gravel, sand, etc.) or smoke (asphalt, concrete, etc.) generated
        ///     by the wheels.
        /// </summary>
        [FormerlySerializedAs("dustPrefab")]
        [Tooltip(
            "    Prefab of the particle system for generating dust as a result of traveling over sand, gravel, etc.")]
        public GameObject particlePrefab;

        /// <summary>
        ///     Prefab of the particle system for generating surface chunks / dirt that gets thrown behind the wheel when going
        ///     over soft surface.
        /// </summary>
        [Tooltip(
            "    Prefab of the particle system for generating surface chunks / dirt that gets thrown behind the wheel when going over soft surface.")]
        public GameObject chunkPrefab;

        /// <summary>
        ///     Surface preset used when there are no matches in the surfaceMaps list for the current surface.
        /// </summary>
        [Tooltip("    Surface preset used when there are no matches in the surfaceMaps list for the current surface.")]
        public SurfacePreset fallbackSurfacePreset;

        /// <summary>
        ///     Surface maps - each represents a single ground surface.
        /// </summary>
        [SerializeField]
        [Tooltip("    Surface maps - each represents a single ground surface.")]
        public List<SurfaceMap> surfaceMaps = new List<SurfaceMap>();
    }
}