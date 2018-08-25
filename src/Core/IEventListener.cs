﻿namespace Fettle.Core
{
    public interface IEventListener
    {
        void BeginCoverageAnalysisOfTestCase(string fullTestName, int index, int total);

        void BeginMutationOfFile(string filePath, string baseSourceDirectory, int index, int total);
        void MemberMutating(string name);
        void SyntaxNodeMutating(int index, int total);
        void MutantSurvived(SurvivingMutant survivingMutant);
        void EndMutationOfFile(string filePath);
    }
}