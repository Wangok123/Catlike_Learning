using UnityEngine;
using UnityEngine.Rendering;

namespace CustomRenderPipeline.Runtime
{
    public partial class CameraRenderer
    {
        static ShaderTagId unlitShaderTagId = new ShaderTagId("SRPDefaultUnlit");

        private const string bufferName = "Render Camera";

        ScriptableRenderContext context;
        CullingResults cullingResults;
        Camera camera;

        CommandBuffer buffer = new CommandBuffer
        {
            name = bufferName
        };

        public void Render(ScriptableRenderContext context, Camera camera)
        {
            this.context = context;
            this.camera = camera;

            PrepareBuffer();
            PrepareForSceneWindow();
            if (!Cull())
            {
                return;
            }

            Setup();
            DrawVisibleGeometry();
            DrawUnsupportedShaders();
            DrawGizmos();
            Submit();
        }

        void DrawVisibleGeometry()
        {
            var sortingSettings = new SortingSettings(camera)
            {
                criteria = SortingCriteria.CommonOpaque
            };
            var drawingSettings = new DrawingSettings(unlitShaderTagId, sortingSettings);
            var filteringSettings = new FilteringSettings(RenderQueueRange.opaque);

            context.DrawRenderers(
                cullingResults, ref drawingSettings, ref filteringSettings
            );

            context.DrawSkybox(camera);

            sortingSettings.criteria = SortingCriteria.CommonTransparent;
            drawingSettings.sortingSettings = sortingSettings;
            filteringSettings.renderQueueRange = RenderQueueRange.transparent;

            context.DrawRenderers(
                cullingResults, ref drawingSettings, ref filteringSettings
            );
        }

        void Setup()
        {
            context.SetupCameraProperties(camera);
            CameraClearFlags flags = camera.clearFlags;
            buffer.ClearRenderTarget(flags <= CameraClearFlags.Depth, flags <= CameraClearFlags.Color,
                flags == CameraClearFlags.Color ? camera.backgroundColor.linear : Color.clear);
            buffer.BeginSample(SampleName);
            ExecuteBuffer();
        }

        void Submit()
        {
            buffer.EndSample(SampleName);
            ExecuteBuffer();
            context.Submit();
        }

        void ExecuteBuffer()
        {
            context.ExecuteCommandBuffer(buffer);
            buffer.Clear();
        }

        bool Cull()
        {
            if (camera.TryGetCullingParameters(out ScriptableCullingParameters p))
            {
                cullingResults = context.Cull(ref p);
                return true;
            }

            return false;
        }
    }
}