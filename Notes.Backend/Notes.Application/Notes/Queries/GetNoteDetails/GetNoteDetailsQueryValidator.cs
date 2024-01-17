using FluentValidation;
using Notes.Application.Notes.Commands.UpdateNote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Notes.Queries.GetNoteDetails
{
    public class GetNoteDetailsQueryValidator : AbstractValidator<GetNoteDetailsQuery>
    {
        public GetNoteDetailsQueryValidator() 
        {
            RuleFor(noteDetails =>
                noteDetails.UserId).NotEqual(Guid.Empty);
            RuleFor(noteDetails =>
                noteDetails.Id).NotEqual(Guid.Empty);
        }
    }
}
