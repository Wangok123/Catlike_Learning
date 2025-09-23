using UnityEngine;
using UnityEngine.Rendering;

namespace CustomRenderPipeline.Runtime
{
    public class CameraRenderer
    {
        static ShaderTagId unlitShaderTagId = new ShaderTagId("SRPDefaultUnlit");
        private const string bufferName = "Render Camera";
        
        ScriptableRenderContext context;
        CullingResults cullingResults;
        Camera camera;

        CommandBuffer buffer = new CommandBuffer {
            name = bufferName
        };

        public void Render (ScriptableRenderContext context, Camera camera) {
            this.context = context;
            this.camera = camera;
            
            if (!Cull()) {
                return;
            }
            
            Setup();
            DrawVisibleGeometry();
            Submit();
        }
        
        void DrawVisibleGeometry () {
            var sortingSettings = new SortingSettings(camera);
            var drawingSettings = new DrawingSettings(unlitShaderTagId, sortingSettings);
            var filteringSettings = new FilteringSettings(RenderQueueRange.all);

            context.DrawRenderers(
                cullingResults, ref drawingSettings, ref filteringSettings
            );
            
            context.DrawSkybox(camera);
        }
        
        void Setup () {
            context.SetupCameraProperties(camera);
            buffer.ClearRenderTarget(true, true, Color.clear);
            buffer.BeginSample(bufferName);
            ExecuteBuffer();
        }
        
        void Submit () {
            buffer.EndSample(bufferName);
            ExecuteBuffer();
            context.Submit();
        }
        
        void ExecuteBuffer () {
            context.ExecuteCommandBuffer(buffer);
            buffer.Clear();
        }
        
        bool Cull ()
        {
            if (camera.TryGetCullingParameters(out ScriptableCullingParameters p)) {
                cullingResults = context.Cull(ref p);
                return true;
            }
            return false;
        }
    }
}