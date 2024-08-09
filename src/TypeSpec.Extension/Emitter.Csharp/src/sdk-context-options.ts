// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

import { CreateSdkContextOptions } from "@azure-tools/typespec-client-generator-core";

export const azureSDKContextOptions: CreateSdkContextOptions = {
    versioning: {},
    // TODO: replace with `@hasJsonConverter` when it is available
    additionalDecorators: []
};
