#region License

/*
 * Copyright 2002-2009 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF Any KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

#region

using Spring.Integration.Core;
using Spring.Integration.Selector;

#endregion

namespace Spring.Integration.Tests.Config
{
    /// <author>Mark Fisher</author>
    /// <author>Andreas D�hring (.NET)</author>
    public class TestSelector : IMessageSelector
    {
        private readonly bool _accept;

        public TestSelector(bool accept)
        {
            _accept = accept;
        }

        public bool Accept(IMessage message)
        {
            return _accept;
        }
    }
}