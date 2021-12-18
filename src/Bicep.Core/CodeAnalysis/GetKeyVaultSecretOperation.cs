// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Bicep.Core.CodeAnalysis
{
    public record GetKeyVaultSecretOperation(
        ResourceIdOperation KeyVaultId,
        Operation SecretName,
        Operation? SecretVersion) : Operation
    {
        public override void Accept(IOperationVisitor visitor)
            => visitor.VisitGetKeyVaultSecretOperation(this);
    }
}