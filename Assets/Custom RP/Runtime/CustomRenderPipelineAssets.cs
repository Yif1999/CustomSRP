using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(menuName = "Rendering/Custom Render Pipeline")]
public class CustomRenderPipelineAssets : RenderPipelineAsset
{
	protected override RenderPipeline CreatePipeline()
	{
		return new CustomRenderPipeline();
	}
}