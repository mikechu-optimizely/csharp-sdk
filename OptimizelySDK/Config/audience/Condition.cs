﻿using OptimizelySDK.Entity;

namespace OptimizelySDK.Config.audience
{
    public interface Condition 
    {
        bool? Evaluate(ProjectConfig config, UserAttributes attributes);

        string ToJson();

        string GetOperandOrId();
    }
}
