using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appleMusic.Queries;
using HotChocolate.Types;

namespace appleMusic.GraphQl.Types
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor
                .Field(f => f.GetTracks(default!))
                .Type<ListType<TrackType>>();

            descriptor
                .Field(f => f.GetTrack(default!, default!))
                .Type<TrackType>();
        }
    }

}