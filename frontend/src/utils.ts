export function isUuid(uuid: string): boolean{
  const hex = '[0-9a-fA-F]';
  const uuidRegex = new RegExp(`^${hex}{8}-${hex}{4}-${hex}{4}-${hex}{4}-${hex}{12}$`);
  return uuidRegex.test(uuid);
}

export class InvalidUuidError extends Error {
  constructor(message: string) {
    super(message);
    this.name = 'InvalidUuidError';
  }
}