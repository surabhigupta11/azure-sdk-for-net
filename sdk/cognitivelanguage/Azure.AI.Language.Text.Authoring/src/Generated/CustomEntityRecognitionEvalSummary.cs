// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text.Authoring
{
    /// <summary> Represents the evaluation summary for a custom entity recognition project. </summary>
    public partial class CustomEntityRecognitionEvalSummary : TextAuthoringEvalSummary
    {
        /// <summary> Initializes a new instance of <see cref="CustomEntityRecognitionEvalSummary"/>. </summary>
        /// <param name="evaluationOptions"> Represents the options used running the evaluation. </param>
        /// <param name="customEntityRecognitionEvaluation"> Contains the data related to extraction evaluation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="evaluationOptions"/> or <paramref name="customEntityRecognitionEvaluation"/> is null. </exception>
        internal CustomEntityRecognitionEvalSummary(TextAuthoringEvaluationDetails evaluationOptions, EntityRecognitionEvalSummary customEntityRecognitionEvaluation) : base(evaluationOptions)
        {
            Argument.AssertNotNull(evaluationOptions, nameof(evaluationOptions));
            Argument.AssertNotNull(customEntityRecognitionEvaluation, nameof(customEntityRecognitionEvaluation));

            ProjectKind = TextAuthoringProjectKind.CustomEntityRecognition;
            CustomEntityRecognitionEvaluation = customEntityRecognitionEvaluation;
        }

        /// <summary> Initializes a new instance of <see cref="CustomEntityRecognitionEvalSummary"/>. </summary>
        /// <param name="projectKind"> Represents the project type that the evaluation ran on. </param>
        /// <param name="evaluationOptions"> Represents the options used running the evaluation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="customEntityRecognitionEvaluation"> Contains the data related to extraction evaluation. </param>
        internal CustomEntityRecognitionEvalSummary(TextAuthoringProjectKind projectKind, TextAuthoringEvaluationDetails evaluationOptions, IDictionary<string, BinaryData> serializedAdditionalRawData, EntityRecognitionEvalSummary customEntityRecognitionEvaluation) : base(projectKind, evaluationOptions, serializedAdditionalRawData)
        {
            CustomEntityRecognitionEvaluation = customEntityRecognitionEvaluation;
        }

        /// <summary> Initializes a new instance of <see cref="CustomEntityRecognitionEvalSummary"/> for deserialization. </summary>
        internal CustomEntityRecognitionEvalSummary()
        {
        }

        /// <summary> Contains the data related to extraction evaluation. </summary>
        public EntityRecognitionEvalSummary CustomEntityRecognitionEvaluation { get; }
    }
}
