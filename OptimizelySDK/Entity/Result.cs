﻿/* 
 * Copyright 2020-2021 Optimizely
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using OptimizelySDK.OptimizelyDecisions;

namespace OptimizelySDK.Entity
{
    public class Result<T>
    {
        public T ResultObject;
        public DecisionReasons DecisionReasons;
        public bool SkipToEveryoneElse;

        public static Result<T> NewResult(T resultObject, bool skipToEveryoneElse, DecisionReasons decisionReasons)
        {
            return new Result<T> { DecisionReasons = decisionReasons, ResultObject = resultObject, SkipToEveryoneElse = skipToEveryoneElse };
        }
        public static Result<T> NewResult(T resultObject, DecisionReasons decisionReasons)
        {
            return new Result<T> { DecisionReasons = decisionReasons, ResultObject = resultObject };
        }

        public Result<T> SetReasons(DecisionReasons decisionReasons)
        {
            DecisionReasons =  decisionReasons;

            return this;
        }

        public static Result<T> NullResult(DecisionReasons decisionReasons)
        {
            return NewResult(default(T), decisionReasons);
        }
    }
}
