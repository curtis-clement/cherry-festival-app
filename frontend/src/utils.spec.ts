import { describe, it, expect } from 'vitest';
import { isUuid, InvalidUuidError } from '@/utils';

describe('utils', () => {
  describe('isUuid', () => {
    it.each([
      ['123e4567-e89b-12d3-a456-426614174000', true],
      ['987fcdeb-51a2-3e4b-9876-543210abcdef', true],
      ['not-a-uuid', false],
      ['123e4567-e89b-12d3-a456-42661417400', false],  // too short
      ['123e4567-e89b-12d3-a456-4266141740000', false],  // too long
      ['123e4567-e89b-12d3-a456-42661417400g', false],  // invalid character
      ['', false],
    ])('should return %s for %s', (uuid, expected) => {
      expect(isUuid(uuid)).toBe(expected);
    });

    it('should create error with correct message and name', () => {
      const errorMessage: string = 'Invalid UUID was provided: not-a-uuid';
      const error: InvalidUuidError = new InvalidUuidError(errorMessage);

      expect(error.message).toBe(errorMessage);
      expect(error.name).toBe('InvalidUuidError');
    });

    it('should throw an error when invalid UUID is provided', () => {
      const error = new InvalidUuidError('test');
      expect(error).toBeInstanceOf(Error);
    });
  });
});