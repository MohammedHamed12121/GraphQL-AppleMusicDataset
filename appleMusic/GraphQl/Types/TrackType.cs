using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appleMusic.Models;
using appleMusic.Queries;
using HotChocolate.Types;

namespace appleMusic.GraphQl.Types
{
    public class TrackType : ObjectType<Track>
    {
        protected override void Configure(IObjectTypeDescriptor<Track> descriptor)
        {
            descriptor
                .Field(f => f.Id)
                .Type<LongType>();

            descriptor
                .Field(f => f.TrackName)
                .Type<StringType>();

            descriptor
                .Field(f => f.TrackCensoredName)
                .Type<StringType>();
        }
    }
}